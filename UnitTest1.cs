namespace TesmoQA
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Fail("Error al validar los campos");
        }
        [Fact]
        public void Test2()
        {
            Console.WriteLine("Exito");
            Assert.True(true, "Exito");
        }
    }
}