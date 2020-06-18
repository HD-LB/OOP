
namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;


    public class AudioDocument : MultimediaDocument, IDocument
    {
        //Contsructor
        public AudioDocument(string name, string content = null, int size = 0, int lenght = 0, double sampleRate = 0.0)
            : base(name, content, size, lenght)
        {
            this.SampleRate = sampleRate;
        }

        //Proparies
        public double SampleRate { get; private set; }

        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "samplerate")
            {
                this.SampleRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.SampleRate != 0)
            {
                output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
                base.SaveAllProperties(output);
            }
        }

    }
}
