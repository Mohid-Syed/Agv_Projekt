

public abstract class Station : BahnElement
{


  public Station(uint ausrichtung) : base(ausrichtung)
  {
    this.setHatVerbindung(this.getAusrichtung() % 4, true);
  }
}