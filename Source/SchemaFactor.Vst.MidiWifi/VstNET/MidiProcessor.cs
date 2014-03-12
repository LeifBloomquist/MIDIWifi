namespace SchemaFactor.Vst.MidiWifi
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Framework;

    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Implements the incoming Midi event handling for the plugin.
    /// </summary>
    class MidiProcessor : IVstMidiProcessor
    {
        private Plugin _plugin = null;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="plugin">Must not be null.</param>
        public MidiProcessor(Plugin plugin)
        {
            _plugin = plugin;
            Events = new VstEventCollection();
        }

        /// <summary>
        /// Gets the midi inputEvents that should be processed in the current cycle.
        /// </summary>
        public VstEventCollection Events { get; private set; }

#region IVstMidiProcessor Members

        public int ChannelCount
        {
            get { return _plugin.ChannelCount; }
        }

        // Process the incoming MIDI events.  *** This is the core of the VST right here. ***
        public void Process(VstEventCollection inputEvents)
        {
            if (_plugin == null) return;
            // ignore inputEvents - we should never receive any MIDI events anyway.

            byte[] buffer = new byte[4];

            while (_plugin.messageQueue.TryDequeue(out buffer))
            {
                //VstMidiEvent mappedEvent = new VstMidiEvent(midiInputEvent.DeltaFrames, midiInputEvent.NoteLength, midiInputEvent.NoteOffset, midi, midiInputEvent.Detune, midiInputEvent.NoteOffVelocity);
                VstMidiEvent newEvent = new VstMidiEvent(0,0, 0, buffer, 0, 0);
                Events.Add(newEvent);
            }
        } // Process

   #endregion 
    }
}
