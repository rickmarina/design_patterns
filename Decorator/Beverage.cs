public abstract class Beverage {
    public string description ="unknown coffee"; 
    public virtual string GetDescription() => description;
    public abstract double cost();
}