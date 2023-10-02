namespace TestProject
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //Arange |
            string name = "Rokas";
            string expectedName = "Ponas Rokas";

            //Act 
            Program.KeistiVarda(ref name);

            //Assert
            Assert.AreEqual(expectedName, name);

        }
        [Test]
        public void TestIntArrayEquality()
        {
            int[] expected = { 1, 2, 3 };
            int[] actual = { 1, 2, 3 };

            Assert.AreEqual(expected, actual);
        }
    }
}