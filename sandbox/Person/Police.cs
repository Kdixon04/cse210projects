class Police : Person
{
    private string _weapon;

    public Police(string firstName, string lastName, int age, double weight, string weapon) : base (firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public override string GetPersonInfo()
    {
        return $"Police: Weapon: {_weapon}: {base.GetPersonInfo()}";
    }

    public override double GetSalary()
    {
        return 145000.21;
    }
}