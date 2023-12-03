using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using Newtonsoft.Json;

namespace SharpRPC
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public DiscordRPC.Button[] buttons;
        public DiscordRpcClient client;
        public Party party;
        public Timestamps rpctimestamps;

        // I used this variable to differentiate when the user presses the exit button and when the user presses the close button in the title bar
        bool Exited = false;

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            this.DoubleBuffered = true;
        }

        private void CheckTimestamp()
        {
            if (this.checkTime.Checked)
            {
                rpctimestamps = Timestamps.Now;
            }
            else
            {
                rpctimestamps = null;
            }
        }

        private void PartySetting()
        {
            var partySizeSelected = ((int)this.partySize.Value);
            var partyMaxSelected = ((int)this.partyMax.Value);
            if (partySizeSelected == 0 && partyMaxSelected == 0)
            {
                party = null;
            }
            else
            {
                party = new Party()
                {
                    ID = Secrets.CreateFriendlySecret(new Random()),
                    Size = partySizeSelected,
                    Max = partyMaxSelected,
                    Privacy = Party.PrivacySetting.Public
                };
            }
        }

        private void SettingButtons()
        {
            if (this.textBox8.Text.Length == 0 && this.textBox10.Text.Length == 0)
            {
                buttons = null;
            }

            if (this.textBox8.Text.Length >= 1 && this.textBox10.Text.Length == 0)
            {
                buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = this.textBox8.Text, Url = this.textBox9.Text }
                };
            }

            if (this.textBox10.Text.Length >= 1 && this.textBox8.Text.Length == 0)
            {
                buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = this.textBox10.Text, Url = this.textBox11.Text }
                };
            }

            if (this.textBox8.Text.Length >= 1 && this.textBox10.Text.Length >= 1)
            {
                buttons = new DiscordRPC.Button[] { new DiscordRPC.Button() { Label = this.textBox8.Text, Url = textBox9.Text, }, new DiscordRPC.Button() { Label = textBox10.Text, Url = textBox11.Text, } };
            }
        }

        private void Initialize()
        {
            // This function performs the settings for the numericUpDown Party
            this.PartySetting();

            // If the user leaves some spaces, this function avoids errors and sets up buttons
            this.SettingButtons();

            // if user want use timer 
            this.CheckTimestamp();

            // We register an Application ID 
            client = new DiscordRpcClient(this.txtApplication.Text);
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            // Ready Client event
            client.OnReady += (sender, e) =>
            {
                this.GetAvatar(e);
                this.username.BeginInvoke(delegate { this.username.Text = e.User.Username + "#" + e.User.Discriminator; });
                this.statusUser.BeginInvoke(delegate { this.statusUser.Text = "Online"; });
            };

            // Attempts to initalize a connection to the Discord IPC
            client.Initialize();

            // Set Presence 
            client.SetPresence(new RichPresence()
            {
                Details = this.txtDetail.Text,
                State = this.txtState.Text,
                Party = this.party,
                Timestamps = this.rpctimestamps,
                Buttons = this.buttons,
                Assets = new Assets()
                {
                    LargeImageKey = this.comboLargeKey.Text,
                    LargeImageText = this.textBox5.Text,
                    SmallImageKey = this.comboSmallKey.Text,
                    SmallImageText = this.textBox7.Text
                }
            });
        }

        private void Deinitialize()
        {
            // Disconnect Sharp Rich Presence
            client.Dispose();
            this.pictureAvatar.Image = null;
            this.username.Text = "Unknow";
            this.statusUser.Text = "Unknow";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Checks if the user entered the Application ID correctly
            if (this.txtApplication.Text.Length >= 18)
            {
                this.Initialize();
            }
            else
            {
                // Here the error message appears
                MessageShow message = new MessageShow();
                message.Show();
                message.Show("Please enter your Application ID correctly");
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // Disconnting 
            this.Deinitialize();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // This is show in tashbar program 
            this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This event is called so that when the user closes the program, it does not close the program
            if (!Exited)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exited = true;
            Application.Exit();
        }

        private async void GetAvatar(ReadyMessage e)
        {
            // This function gets the Avatar
            string uri = e.User.GetAvatarURL(User.AvatarFormat.PNG).Split("?")[0] + "?size=100";
            var request = WebRequest.Create(uri);
            using (var response = await request.GetResponseAsync())
            using (var stream = response.GetResponseStream())
            {
                this.pictureAvatar.Image = Bitmap.FromStream(stream);
            }
        }

        private async void GetAsstes()
        {
            // This function gets the Asstes
            if (this.txtApplication.Text.Length >= 18)
            {
                using (var webClient = new WebClient())
                {
                    try
                    {
                        var json = await webClient.DownloadStringTaskAsync("https://discordapp.com/api/oauth2/applications/" + txtApplication.Text + "/assets");
                        dynamic dynJson = JsonConvert.DeserializeObject(json);
                        foreach (var item in dynJson)
                        {
                            this.comboLargeKey.Items.Add(item.name);
                            this.comboSmallKey.Items.Add(item.name);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        private void txtApplication_TextChanged(object sender, EventArgs e)
        {
            // Here we call the function
            this.GetAsstes();
        }
    }
}
