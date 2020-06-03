namespace TemplateMethodPattern
{
    public abstract class TemplateMethod
    {
        private readonly ExternalTool _tool;

        public TemplateMethod(ExternalTool tool)
        {
            this._tool = tool;
        }

        public void Method ()
        {
            this._tool.ActionBefore();
            this.SubMethod();
            this._tool.ActionAfter();
        }

        protected abstract void SubMethod();
    }
}
