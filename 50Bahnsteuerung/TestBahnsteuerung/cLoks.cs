using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Borys.Bahn.Bahnsteuerung
{
  class cLoks
  {
    /// <summary>
    /// Liste der vereinbartenLoks
    /// </summary>
    private List<cLok> Liste;
    /// <summary>
    /// Panel für die Buttons
    /// </summary>
    private Panel LokButtonPanel;
    /// <summary>
    /// Eventhandler für alle Button-Klicks
    /// </summary>
    private EventHandler ClickHandler;


    /// <summary>
    /// Konstruktor
    /// </summary>
    /// <param name="pPanel">Panel für die Auswahlbuttons</param>
    /// <param name="pClick">Callback-Funktion für die Auswahl</param>
    public cLoks(Panel pPanel, EventHandler pClick)
    {
      Liste = new List<cLok>();
      LokButtonPanel = pPanel;
      ClickHandler = pClick;
    }

    /// <summary>
    /// eine Lok der Liste hinzufügen
    /// </summary>
    /// <param name="sName">Lok-Bezeichnung</param>
    /// <param name="uiAdresse">Lok-Adresse</param>
    internal void Neu(string sName, uint uiAdresse)
    {
      cLok neue;
      neue = new cLok(sName, uiAdresse, LokButtonPanel, ClickHandler);
      Liste.Add(neue);
    }
  }
}