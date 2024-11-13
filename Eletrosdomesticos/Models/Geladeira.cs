namespace Eletrosdomesticos.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, ConsumoEnergetico: {ConsumoEnergetico}, CapacidadeLitros {CapacidadeLitros}, TemFreezer {TemFreezer}";
        }
    }
}
