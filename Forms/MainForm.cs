using FCGG.Forms.Controls;
using FontAwesome.Sharp;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FCGG.Forms
{
    public partial class MainForm : Form
    {
        private readonly Manager _manager;

        private readonly Dictionary<uint, ChannelControl> _channelsTracked = new Dictionary<uint, ChannelControl>();

        public MainForm()
        {
            InitializeComponent();

            _manager = new Manager();

            _manager.StateChange += (state) =>
            { 
                toolStripSeparatorMain.Visible =
                iconToolStripButtonAddChannel.Visible =
                iconToolStripButtonRemoveChannel.Visible = state;

                if (state)
                {
                    iconToolStripToggleRunButton.IconChar = IconChar.Stop;
                    iconToolStripToggleRunButton.IconColor = Color.Red;
                    iconToolStripToggleRunButton.Text = "Stop";
                }
                else
                {
                    iconToolStripToggleRunButton.IconChar = IconChar.Play;
                    iconToolStripToggleRunButton.IconColor = Color.Green;
                    iconToolStripToggleRunButton.Text = "Start";

                    _channelsTracked.Clear();
                    flowLayoutPanelChannels.Controls.Clear();
                }
            };

            _manager.ChannelAdded += (ch) => 
            {
                var chAdded = new ChannelControl(ch);

                _channelsTracked.Add(ch.Number, chAdded);

                flowLayoutPanelChannels.Controls.Add(chAdded); 
            };

            _manager.ChannelRemoved += (ch) =>
            {
                flowLayoutPanelChannels.Controls.Remove(_channelsTracked[ch.Number]);
                _channelsTracked.Remove(ch.Number);
            };

            FormClosing += (s, e) =>
            {
                if (_manager.IsRunning)
                {
                    _manager.Stop();
                }
            };

            iconToolStripToggleRunButton.Click += (s, e) =>
            { 
                if (_manager.IsRunning)
                {
                    _manager.Stop();
                }
                else
                {
                    _manager.Start();
                }
            };

            iconToolStripButtonAddChannel.Click += (s, e) =>
            {
                _manager.AddChannel();
            };

            toolStrip.Items.Add(new ToolStripSpringLabel { Font = new Font("Consolas", 9), TextAlign = ContentAlignment.MiddleRight, Text = $"Skia v{SkiaSharp.SkiaSharpVersion.Native} / ffmpeg v{_manager.FfmpegVersion}" });

            toolStripSeparatorMain.Visible = iconToolStripButtonAddChannel.Visible = iconToolStripButtonRemoveChannel.Visible = false;

            //Icon = Icon.FromHandle(IconChar.Cog.ToBitmap(16, Color.Black).GetHicon());

            //var toolStripButton = new IconToolStripButton { IconChar = IconChar.Play };

            //toolStrip1.Items.Add(toolStripButton);
        }
    }
}
