using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Speech.Synthesis;
using System.IO;

namespace StdioHeadlines
{
    public partial class FrmMain : Form
    {
        private StCloud StCloud = new StCloud();
        private List<NewModel> newModels = new List<NewModel>();
        private SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            JObject json = this.StCloud.GetContent();
            if(json.Value<JObject>("result").Value<string>("stat") == "1")
            {
                JArray jdata = json.Value<JObject>("result").Value<JArray>("data");
                foreach(JObject jitem in jdata)
                {
                    NewModel newModel = JsonConvert.DeserializeObject<NewModel>(jitem.ToString());
                    this.newModels.Add(newModel);
                    this.lstNews.Items.Add(newModel);
                }
            }
        }

        private void lstNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewModel newModel = this.lstNews.SelectedItem as NewModel;
            if(newModel != null)
            {
                this.rtbContent.Text = newModel.GetContent();
                Stream stream = this.StCloud.GetPicStream(newModel.thumbnail_pic_s);
                Bitmap bmp = new Bitmap(stream);
                this.picNew.BackgroundImage = bmp;
                string content = this.StCloud.GetHeadline(newModel.url);
                this.rtbHead.Text = content;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.speechSynthesizer.SpeakAsync(this.rtbHead.Text);
        }
    }
}
