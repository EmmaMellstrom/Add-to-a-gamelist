using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddGamesList
{
    class GameInformation
    {
        private string m_title;
        private int m_releaseDate;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public int ReleaseDate
        {
            get { return m_releaseDate; }
            set { m_releaseDate = value; }
        }

        public GameInformation()
        {
            m_title = string.Empty;
            m_releaseDate = 0;
        }

    }
}
