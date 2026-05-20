using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
    class cCmds
    {
        List<cCmd> Liste;
        /// <summary>
        /// Panel für neue Kommandobuttons
        /// </summary>
        private Panel CmdButtonPanel;
        /// <summary>
        /// Eventhandler für Klick auf Kommandobuttons
        /// </summary>
        private EventHandler ClickHandler;


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="pPanel">Panel für Kommando-Buttons</param>
        /// <param name="pClick">Eventhandler für Klicks</param>
        public cCmds(Panel pPanel, EventHandler pClick)
        {
            Liste = new List<cCmd>();
            CmdButtonPanel = pPanel;
            ClickHandler = pClick;
        }

        /// <summary>
        /// neues Kommando zur Liste zufügen
        /// </summary>
        /// <param name="sName">Name des Kommandos</param>
        /// <param name="pStart2">Startbit2 (0 oder 1)</param>
        /// <param name="pBefehl">Befehlsbits</param>
        internal void Neu(string sName, uint pStart2, uint pBefehl)
        {
            cCmd neues = new cCmd(sName, pStart2, pBefehl, CmdButtonPanel, ClickHandler);
            Liste.Add(neues);
        }
    }
}