namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;


    public class VideoDocument : MultimediaDocument, IDocument
    {
        //Constructor
        public VideoDocument(string name, string content = null, int size = 0, int lenght = 0, int frameRate = 0)
            : base(name, content, size, lenght)
        {
            this.FrameRate = frameRate;
        }

        //Proparties
        public int FrameRate { get; private set; }

        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "frame")
            {
                this.FrameRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }


        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.FrameRate != 0)
            {
                output.Add(new KeyValuePair<string, object>("frame", this.FrameRate));
                base.SaveAllProperties(output);
            }
        }
    }
}
