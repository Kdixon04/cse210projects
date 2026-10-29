class Police : Person
{
    private string _weapon;

    public Police(string firstName, string lastName, int age, double weight, string weapon) : base (firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public string GetPoliceInfo()
    {
        return $"Weapon: {_weapon}: {GetPersonInfo()}";
    }
}