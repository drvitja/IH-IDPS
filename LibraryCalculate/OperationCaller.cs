namespace LibraryCalculate
{
    public class OperationCaller : ICaller
    {
        Dictionary<string, ICalculation> operatorList;

        public OperationCaller()
        {
            System.Reflection.Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().Where(m => m.GetName().Name == "LibraryCalculate").First();
            IEnumerable<Type> commands = assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ICalculation)));

            foreach (Type command in commands)
            {
                ICalculation instance = (ICalculation)Activator.CreateInstance(command);
                this.operatorList.Add(instance.Operator, instance);
            }
        //    operatorList = new Dictionary<string, ICalculation>()
        //{
        //    {"+", new Add()},
        //    {"-", new Subtract()},
        //    {"*", new Multiply()},
        //    {"/", new Divide()},
        //    {"MOD", new Modulo()},
        //    {"^", new Power()},
        //    {"Rt", new Root()},
        //    {"%", new Percent()}
        //};
        }

        public ICalculation GetCalculation(string op)
        {
            if (op != null)
            {
                if (operatorList.ContainsKey(op))
                {
                    return operatorList[op];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unknown Operator");
                }
            }
            else
            {
                throw new ArgumentNullException("Operator cant be null");
            }
        }
    }
}
