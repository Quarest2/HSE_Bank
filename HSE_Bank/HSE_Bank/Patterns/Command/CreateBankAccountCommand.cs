using HSE_Bank.Patterns.Facade;

namespace HSE_Bank.Patterns.Command;

public class CreateBankAccountCommand : ICommand
{
    private readonly FinanceFacade _facade;
    private readonly string _name;
    private readonly decimal _initialBalance;

    public CreateBankAccountCommand(FinanceFacade facade, string name, decimal initialBalance)
    {
        _facade = facade;
        _name = name;
        _initialBalance = initialBalance;
    }

    public void Execute()
    {
        _facade.CreateBankAccount(_name, _initialBalance);
    }
}