using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FacadeTelephone
    {
        TelephoneModel model;
        SystemTelephone system;
        BodyTelephone body;
        TelephoneAccesories accesories;
        public FacadeTelephone()
        {
            model = new TelephoneModel();
            system = new SystemTelephone();
            body = new BodyTelephone();
            accesories = new TelephoneAccesories();
        }
        public void CreateCompletTelephone()
        {
            model.SetModel();
            system.SetSystem();
            body.SetBody();
            accesories.SetAccessories();
        }

    }
}
