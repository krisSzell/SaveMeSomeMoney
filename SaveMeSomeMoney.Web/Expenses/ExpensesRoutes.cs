namespace SaveMeSomeMoney.Web.Expenses
{
    public static class ExpensesRoutes
    {
        private static readonly string _routePrefix = "/api/expenses/";

        public static string GetAll = $"{_routePrefix}getAll";
        public static string Add = $"{_routePrefix}add";
        public static string Update = $"{_routePrefix}update/{{id}}";
        public static string Remove = $"{_routePrefix}remove/{{id}}";
    }
}
