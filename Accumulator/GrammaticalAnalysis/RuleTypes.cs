namespace SimulatorAcc.GrammaticalAnalysis
{
    public enum RuleTypes
    {
        Data,
        Code,
        Statement,
        NotInitStatement,
        Label,
        LoadVariable,
        LoadNumber,
        VariableOperation,
        NumberOperation,
        Store,
        UnconditionalJump,
        conditionalJump,
        Nop,
        Halt,
        IO,
        None
    }
}