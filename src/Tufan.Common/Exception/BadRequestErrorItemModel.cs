namespace Tufan.Common.Exception
{
    public class BadRequestErrorItemModel
    {
        public string PropertyName { get; set; }

        public string ErrorMessage { get; set; }

        public object AttemptedValue { get; set; }

        public string ErrorCode { get; set; }
    }
}