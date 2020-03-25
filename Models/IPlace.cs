namespace platzi_asp_net_core.Models
{
    public interface IPlace
    {
        string Address {get; set;}

        void CleanPlace();
    }
}