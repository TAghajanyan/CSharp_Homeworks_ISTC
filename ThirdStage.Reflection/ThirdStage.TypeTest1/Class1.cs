namespace ThirdStage.TypeTest1
{
    public class MyClass : Interface1, Interface2
    {
        public int myint;
        private string mystring = "Hello";

        public MyClass() { }
        public MyClass(int myint)
        {
            this.myint = myint;
        }


        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }

        public string myString
        {
            get { return mystring; }
        }

        public void MethodA() { }
        public void MethodB() { }

        private string MethodC(string s1, string s2)
        {
            return s1 + s2;
        }

        public void MyMethod(int p1, string p2) { }

    }
}
