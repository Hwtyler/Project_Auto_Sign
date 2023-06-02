//Program written by Tyler Hudgens
//4/24/2023
/*
 * Made for use for Baylor University ITS-Client Services Team
 * to help with the signage process. 
 * 
 * Purpose is to automate as much of the process as possible.
 * 
 */


using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;





namespace Signage_Auto_Work



{
    using System.Diagnostics;
    using Microsoft.Win32;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button to remove Cortana from the computer.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable Cortana for all users
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);

                MessageBox.Show("Cortana has been disabled.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error disabling Cortana: {ex.Message}");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //This calls the bcdedit cmd with the argument to set "recoveryenabled" to "no"
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c bcdedit /set {default} recoveryenabled no");
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi);
            MessageBox.Show("Recovery has been disabled");
        }


        //Button to create and rename the default admin to the new TEA account and password
        //Takes input from the two text boxes to the right of the button.
        private void button3_Click(object sender, EventArgs e)
        {

            string TEAPassword = textBox5.Text;
            string TEAName = textBox2.Text;

            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c net user Administrator {TEAPassword}");
            ProcessStartInfo psi2 = new ProcessStartInfo("cmd.exe", $"/c wmic useraccount where name='Administrator' rename {TEAName}");
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas"; // This will prompt the user to elevate to admin privileges
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            Process.Start(psi);
            Process.Start(psi2);


        }



        private void button4_Click(object sender, EventArgs e)
        {
            string cdPath = @"\\bu-shares\bu-software\Ivanti\ClientInstaller\WebCDF.exe";
            Process.Start(cdPath);
        }

        //Button to open the control panel to the Domain/Computer name changes window.
        //Develop this later. (Developed)
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control", "sysdm.cpl");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error launching system properties: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string groupName = "Administrators";
            string[] Admins = new string[] { @"BAYLOR\DS-Administrators", @"Baylor\ds-its_admins" };



            foreach (string admins in Admins)
            {

                ProcessStartInfo psi = new ProcessStartInfo("net", $"localgroup {groupName} {admins} /add");
                psi.Verb = "runas";             //Runs the command with elevated permissions: Run as Administrator
                psi.CreateNoWindow = true;      //Doesn't show the window
                psi.UseShellExecute = false;    //Run the command directly
                Process.Start(psi);             //Starts the process

            }


            MessageBox.Show("Administrators have been added.");

        }

        private void button8_Click(object sender, EventArgs e)
        {

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus != OperationalStatus.Up || nic.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }

                IPInterfaceProperties ipProps = nic.GetIPProperties();

                if (ipProps.UnicastAddresses.Count == 0 && ipProps.MulticastAddresses.Count == 0)
                {
                    string interfaceName = nic.Name;
                    Process.Start("netsh", $"interface set interface \"{interfaceName}\" admin=disable");
                }




            }
            MessageBox.Show("Unused Network Interfaces have been disabled.");
        }


        //Taskbar editing.
        private void button7_Click(object sender, EventArgs e)
        {

            const string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
            const string valueName = "ShowSearchBoxOnTaskbar";

            try
            {
                Registry.SetValue(key, valueName, 0, RegistryValueKind.DWord);
                MessageBox.Show("Search function has been disabled for all users.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error disabling search function: {ex.Message}");
            }

        }


        //Copy content player to startup.
        private void button9_Click(object sender, EventArgs e)
        {
            string sourcePath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Four Winds Interactive\Content Player.lnk";
            string destinationFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(sourcePath));

            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c copy \"{sourcePath}\" \"{destinationFolder}\"");
            Process.Start(psi);


            MessageBox.Show("Four Winds added to Startup!");

        }


        //Button Adds the User to Administrator's group. This should be the user that will be using the sign.
        private void button10_Click(object sender, EventArgs e)
        {
            string signageGroup = textBox1.Text.Trim();
            string newAdmin = signageGroup;
            string adminGroup = "Administrators";

            ProcessStartInfo psi = new ProcessStartInfo("net", $"localgroup {adminGroup} {newAdmin} /add");
            psi.Verb = "runas";             //Runs the command with elevated permissions: Run as Administrator
            psi.CreateNoWindow = true;      //Doesn't show the window
            psi.UseShellExecute = false;    //Run the command directly
            Process.Start(psi);             //Starts the process

            MessageBox.Show($"Added {newAdmin} to the {adminGroup}!");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        //This Button calls for the User to be added in as the
        //AutoLogin when the computer is ready to be turned over to the deparmtent.
        private void button11_Click(object sender, EventArgs e)
        {

            //using Microsoft.Win32.Registry;

            string userName = textBox1.Text;
            string password = textBox7.Text;

            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\WinLogon\" /v AutoAdminLogon /d 1 /f");
            psi.Verb = "runas";             //Runs the command with elevated permissions: Run as Administrator
            psi.CreateNoWindow = true;      //Doesn't show the window
            psi.UseShellExecute = false;    //Run the command directly






            Process.Start(psi);             //Starts the process


        }




        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program developed by Tyler Hudgens for use at Baylor University, ITS-Client Services. 4/25/2023. Ver. 1.1");
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Process.Start("cmd", "/c start https://webdhcp.baylor.edu");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}