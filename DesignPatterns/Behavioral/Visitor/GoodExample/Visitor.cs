namespace DesignPatterns.Behavioral.Visitor.GoodExample
{
    internal interface Visitor
    {
        public void VisitLaw(Law law);
        public void VisitRestaurant(Restaurant restaurant);
        public void VisitRetail(Retail retail);
    }
}
