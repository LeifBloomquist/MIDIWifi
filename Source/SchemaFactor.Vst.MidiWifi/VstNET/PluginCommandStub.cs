namespace SchemaFactor.Vst.MidiWifi
{
    using Jacobi.Vst.Core.Plugin;
    using Jacobi.Vst.Framework;
    using Jacobi.Vst.Framework.Plugin;
    using System;

    /// <summary>
    /// The public Plugin Command Stub implementation derived from the framework provided <see cref="StdPluginCommandStub"/>.
    /// </summary>
    public class PluginCommandStub : StdPluginDeprecatedCommandStub, IVstPluginCommandStub
    {
        Plugin p = new Plugin();

        /// <summary>
        /// Called by the framework to create the plugin root class.
        /// </summary>
        /// <returns>Never returns null.</returns>
        protected override IVstPlugin CreatePluginInstance()
        {           
            return p;
        }

        /// <summary>
        /// Called by the host.  Returns MIDI Key name, so it is displayed i.e. in the FL Studio Piano Roll.
        /// </summary>
        /// <returns>True if the note map is defined, false otherwise</returns>
        public override bool GetMidiKeyName(Jacobi.Vst.Core.VstMidiKeyName midiKeyName, int channel)
        {
            return false;
        }
    }
}