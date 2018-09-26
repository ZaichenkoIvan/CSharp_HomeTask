namespace HW3_CS_OOP
{
    public interface IAnimal
    {
        string Name
        {
            get;
            set;
        }

        void Voice();
        void Feed();

    }
}