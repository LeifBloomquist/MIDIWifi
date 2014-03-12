namespace SchemaFactor.Vst.MidiWifi
{
    using System;
    using System.IO;
    using System.Text;

    using Jacobi.Vst.Core;
    using Jacobi.Vst.Framework;
    using System.Windows.Forms;

    class PluginPersistence : IVstPluginPersistence
    {
        private Plugin _plugin;
        private Encoding _encoding = Encoding.ASCII;

        public PluginPersistence(Plugin plugin)
        {
            _plugin = plugin;
        }

#region IVstPluginPersistence Members

        public bool CanLoadChunk(VstPatchChunkInfo chunkInfo)
        {
            return true;
        }

        public void ReadPrograms(Stream stream, VstProgramCollection programs)
        {
            if (_plugin == null) return;
        }

        public void WritePrograms(Stream stream, VstProgramCollection programs)
        {
            if (_plugin == null) return;
        }

#endregion

    }
}
