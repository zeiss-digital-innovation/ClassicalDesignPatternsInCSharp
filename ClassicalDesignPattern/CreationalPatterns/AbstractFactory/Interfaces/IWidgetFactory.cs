namespace ClassicalDesignPatternsInCSharp.CreationalPatterns.AbstractFactory.Interfaces
{
    public interface IWidgetFactory
    {
        IScrollbar CreateScrollbar();
        IWindow CreateWindow();
    }
}
