using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._8__Facade_
{
    class FacadeTheater
    {
        dvdPlayer dvd = new dvdPlayer();
        cdPlayer cd = new cdPlayer();
        Tuner tune = new Tuner();
        Amplificador amp = new Amplificador();
        Projector procc = new Projector();

        public void watchMovie()
        {
            tune.on();
            tune.setFrecuency(420);
            dvd.on();
            amp.on();
            amp.setTuner(tune);
            amp.setDVD(dvd);
            procc.on();
            procc.movieMode();
            dvd.play();
        }
        public void stopWatching()
        {
            procc.off();
            dvd.eject();
            dvd.off();
            tune.off();
            amp.off();
      
        }
        public void listenMusic()
        {
            tune.on();
            tune.setFrecuency(69);
            cd.on();
            amp.on();
            amp.setTuner(tune);
            amp.setCD(cd);
            cd.play();
        }
    }
}
