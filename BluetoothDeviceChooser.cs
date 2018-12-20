using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.Personnel
{
    public partial class BluetoothDeviceChooser : Form
    {
        
        public BluetoothDeviceChooser()
        {
            InitializeComponent();
        }

       

        BluetoothClient bluetooth;
        BluetoothDeviceInfo[] deviceInfo;

        private void BluetoothDeviceChooser_Load(object sender, EventArgs e)
        {

            if (BluetoothRadio.IsSupported)
            {
                if (BluetoothRadio.PrimaryRadio.Mode == RadioMode.PowerOff)
                    BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;
                bluetooth = new BluetoothClient();
                deviceInfo = bluetooth.DiscoverDevices(100);
                foreach (var device in deviceInfo)
                {
                    DeviceLists.Items.Add(device.DeviceName + " - " + device.DeviceAddress);
                    device.Update();
                    device.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Bluetooth is not supported by this computer");
                Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            string selectedItem = DeviceLists.SelectedItem.ToString();
            string file = Path.Combine(Directory.GetCurrentDirectory(),@"temp/generated.jpg");
            foreach (var device in deviceInfo)
            {
                var name = new Regex(device.DeviceName);
                var address = new Regex(device.DeviceAddress.ToString());
                if(name.IsMatch(selectedItem) && address.IsMatch(selectedItem))
                {
                    device.SetServiceState(BluetoothService.ObexObjectPush, true);
                    if (!device.Authenticated)
                    {
                        if (!BluetoothSecurity.PairRequest(device.DeviceAddress, "0000"))
                            MessageBox.Show("Request failed");
                        else
                            BluetoothSecurity.PairRequest(device.DeviceAddress, "0000");
                    }
                    
                    var uri = new Uri("obex://" + device.DeviceAddress + "/" + file);
                    var request = new ObexWebRequest(uri);
                    request.ReadFile(file);
                    var response = (ObexWebResponse)request.GetResponse();
                    MessageBox.Show(response.StatusCode.ToString());

                    response.Close();
                }
            }
        }

        private void DeviceSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var pattern = new Regex(DeviceSearch.Text.Trim());
            DeviceLists.Items.Clear();
            if (DeviceSearch.Text.Trim().Length > 0)
            {
                foreach (var device in deviceInfo)
                {
                    if (pattern.IsMatch(device.DeviceName))
                    {
                        DeviceLists.Items.Add(device.DeviceName + " - " + device.DeviceAddress);
                        device.Update();
                        device.Refresh();
                    }
                }
            }
            else
            {
                foreach (var device in deviceInfo)
                {
                    DeviceLists.Items.Add(device.DeviceName + " - " + device.DeviceAddress);
                    device.Update();
                    device.Refresh();
                }
            }
        }
    }
}
