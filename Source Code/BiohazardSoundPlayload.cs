using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Biohazard.SoundMusicPayload
{
    class BiohazardSoundPlayload
    {
        SoundPlayer alarm, musicplayer;
        public void SoundPayload(string bioalarm)
        {
            alarm = new SoundPlayer(bioalarm);
            alarm.PlayLooping();
        }
        public void StopSound(string alarm)
        {
            SoundPlayer xxza = new SoundPlayer();
            xxza = new SoundPlayer(alarm);
            xxza.Stop();
        }
        public void MusicPayload(string music)
        {
            musicplayer = new SoundPlayer(music);
            musicplayer.PlayLooping();
        }
        public void StopMusic(string mussic)
        {
            SoundPlayer sbn_stop = new SoundPlayer();
            sbn_stop = new SoundPlayer(mussic);
            sbn_stop.Stop();
        }
    }
}
