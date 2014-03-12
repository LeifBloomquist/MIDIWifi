using Jacobi.Vst.Core;
using Jacobi.Vst.Framework;
using Jacobi.Vst.Framework.Common;
using Jacobi.Vst.Framework.Plugin;
using System;
using System.Collections.Concurrent;

#pragma warning disable 1591

namespace SchemaFactor.Vst.MidiWifi
{
    /// <summary>
    /// The Plugin root class that implements the interface manager and the plugin midi source.
    /// </summary>
    public class Plugin : VstPluginWithInterfaceManagerBase, IVstPluginMidiSource
    {
        /// <summary>
        /// Threadsafe Queue that holds the incoming MIDI messages.
        /// </summary>
        public ConcurrentQueue<byte[]> messageQueue = new ConcurrentQueue<byte[]>();

        public ulong idleCount { get; set; }
        public ulong packetCount { get; set; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Plugin()
            : base("MIDIWifi", new VstProductInfo("MIDIWifi", "Leif Bloomquist (2014)   Jacobi Software (2012)", 0001),
                VstPluginCategory.Generator, VstPluginCapabilities.NoSoundInStop, 0, 0x323)
        {
            
        }

        /// <summary>
        /// Creates a default instance and reuses that for all threads.
        /// </summary>
        /// <param name="instance">A reference to the default instance or null.</param>
        /// <returns>Returns the default instance.</returns>
        protected override IVstPluginAudioProcessor CreateAudioProcessor(IVstPluginAudioProcessor instance)
        {
            if (instance == null) return new AudioProcessor(this);
            return instance;
        }

        /// <summary>
        /// Creates a default instance and reuses that for all threads.
        /// </summary>
        /// <param name="instance">A reference to the default instance or null.</param>
        /// <returns>Returns the default instance.</returns>
        protected override IVstPluginEditor CreateEditor(IVstPluginEditor instance)
        {
            if (instance == null) return new PluginEditor(this);
            return instance;
        }

        /// <summary>
        /// Creates a default instance and reuses that for all threads.
        /// </summary>
        /// <param name="instance">A reference to the default instance or null.</param>
        /// <returns>Returns the default instance.</returns>
        protected override IVstMidiProcessor CreateMidiProcessor(IVstMidiProcessor instance)
        {
            if (instance == null) return new MidiProcessor(this);
            return instance;
        }

        /// <summary>
        /// Creates a default instance and reuses that for all threads.
        /// </summary>
        /// <param name="instance">A reference to the default instance or null.</param>
        /// <returns>Returns the default instance.</returns>
        protected override IVstPluginPersistence CreatePersistence(IVstPluginPersistence instance)
        {
            if (instance == null) return new PluginPersistence(this);

            return instance;
        }

        /// <summary>
        /// Always returns <b>this</b>.
        /// </summary>
        /// <param name="instance">A reference to the default instance or null.</param>
        /// <returns>Returns the default instance <b>this</b>.</returns>
        protected override IVstPluginMidiSource CreateMidiSource(IVstPluginMidiSource instance)
        {
            return this;
        }

        #region IVstPluginMidiSource Members

        /// <summary>
        /// Returns the channel count as reported by the host
        /// </summary>
        public int ChannelCount
        {
            get
            {
                IVstMidiProcessor midiProcessor = null;
                
                if(Host != null)
                {
                    midiProcessor = Host.GetInstance<IVstMidiProcessor>();
                }

                if (midiProcessor != null)
                {
                    return midiProcessor.ChannelCount;
                }

                return 0;
            }
        }

        #endregion
              
    }
}

#pragma warning restore 1591