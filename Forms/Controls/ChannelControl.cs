using System.Windows.Forms;

namespace FCGG.Forms.Controls
{
    public partial class ChannelControl : UserControl
    {
        public Channel Channel { get; private set; }

        public ChannelControl(Channel channel)
        {
            Channel = channel ?? new Channel(420);

            InitializeComponent();

            labelNumber.Text = $"CH: {Channel.Number}";
        }
    }
}
