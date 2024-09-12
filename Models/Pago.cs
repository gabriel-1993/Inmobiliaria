namespace InmobiliariaVargasHuancaTorrez.Models;

public class Pago {
    public int Id { get; set; }
    public int Id_Contrato { get; set; }
    public int NumeroPago { get; set; }
    public DateTime FechaPago { get; set; }
    public String? Detalle { get; set; }
    public double Importe { get; set; }
    public bool Estado { get; set; }
}