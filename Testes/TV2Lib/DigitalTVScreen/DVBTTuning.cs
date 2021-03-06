﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DirectShowLib;
using DirectShowLib.BDA;

namespace TV2Lib
{
    public class DVBTTuning : ITuningSelector
    {
        private IDVBTuningSpace tuningSpace = null;
        private IDVBTuneRequest tuneRequest = null;

        public DVBTTuning()
        {
            int hr = 0;

            this.tuningSpace = (IDVBTuningSpace)new DVBTuningSpace();
            hr = this.tuningSpace.put_UniqueName("DVBT TuningSpace");
            hr = this.tuningSpace.put_FriendlyName("DVBT TuningSpace");
            hr = this.tuningSpace.put__NetworkType(typeof(DVBTNetworkProvider).GUID);
            hr = this.tuningSpace.put_SystemType(DVBSystemType.Terrestrial);

            ITuneRequest tr = null;

            hr = this.tuningSpace.CreateTuneRequest(out tr);
            DsError.ThrowExceptionForHR(hr);

            this.tuneRequest = (IDVBTuneRequest)tr;

            hr = this.tuneRequest.put_ONID(-1);
            hr = this.tuneRequest.put_TSID(-1);
            hr = this.tuneRequest.put_SID(-1);

            IDVBTLocator locator = (IDVBTLocator)new DVBTLocator();
            hr = locator.put_CarrierFrequency(754000);
            hr = tr.put_Locator(locator as ILocator);
        }

        public ITuningSpace TuningSpace
        {
            get { return tuningSpace; }
        }

        public ITuneRequest TuneRequest
        {
            get { return tuneRequest; }
        }

        public void TuneSelect(int _frequencia, int _onid, int _tsid, int _sid)
        {
            int hr = 0;
            ILocator locator;

            hr = this.tuneRequest.get_Locator(out locator);

            hr = locator.put_CarrierFrequency(_frequencia);
            hr = this.tuneRequest.put_Locator(locator);
            Marshal.ReleaseComObject(locator);

            hr = this.tuneRequest.put_ONID(_onid);
            hr = this.tuneRequest.put_TSID(_tsid);
            hr = this.tuneRequest.put_SID(_sid);
        }
    }

    public interface ITuningSelector
    {
        ITuningSpace TuningSpace { get; }
        ITuneRequest TuneRequest { get; }

        void TuneSelect(int _frequencia, int _onid, int _tsid, int _sid);
    }
}
