using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class SonyWaltman
    {
        private readonly ITapeCasette tapeCasette;

        public SonyWaltman(ITapeCasette tapeCasette)
        {
            this.tapeCasette = tapeCasette;
        }

        public string Play()
        {
            return $"Listening {tapeCasette.Artist} - {tapeCasette.Album}";
        }
    }
}
