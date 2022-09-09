namespace TestCalidadT1
{
    public class Tests
    {
        [Test]
        public void RomanoGeneratorPrueba1()
        {
            //N�mero 1 -> En romano: I
            var romano = RomanoGenerator();
            var test = romano.GetRomano(1);
            Assert.AreEqual("I",test);
        }

        [Test]
        public void RomanoGeneratorPrueba2()
        {

            //N�mero 2 -> En romano: II
            var romano = RomanoGenerator();
            var test = romano.GetRomano(2);
            Assert.AreEqual("II", test);
        }

        [Test]
        public void RomanoGeneratorPrueba3()
        {

            //N�mero 5 -> En romano: V
            var romano = RomanoGenerator();
            var test = romano.GetRomano(5);
            Assert.AreEqual("V", test);
        }

        [Test]
        public void RomanoGeneratorPrueba4()
        {

            //N�mero 8 -> En romano: VIII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(8);
            Assert.AreEqual("VIII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba5()
        {

            //N�mero 10 -> En romano: X
            var romano = RomanoGenerator();
            var test = romano.GetRomano(10);
            Assert.AreEqual("X", test);
        }

        [Test]
        public void RomanoGeneratorPrueba6()
        {

            //N�mero 11 -> En romano: XI
            var romano = RomanoGenerator();
            var test = romano.GetRomano(11);
            Assert.AreEqual("XI", test);
        }

        [Test]
        public void RomanoGeneratorPrueba7()
        {

            //N�mero 7 -> En romano: VII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(7);
            Assert.AreEqual("VII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba8()
        {

            //N�mero 20 -> En romano: XX
            var romano = RomanoGenerator();
            var test = romano.GetRomano(20);
            Assert.AreEqual("XX", test);
        }

        [Test]
        public void RomanoGeneratorPrueba9()
        {

            //N�mero 22 -> En romano: XXII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(22);
            Assert.AreEqual("XXII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba10()
        {

            //N�mero 30 -> En romano: XXX
            var romano = RomanoGenerator();
            var test = romano.GetRomano(30);
            Assert.AreEqual("XXX", test);
        }

        [Test]
        public void RomanoGeneratorPrueba11()
        {

            //N�mero 35 -> En romano: XXXV
            var romano = RomanoGenerator();
            var test = romano.GetRomano(35);
            Assert.AreEqual("XXXV", test);
        }

        [Test]
        public void RomanoGeneratorPrueba12()
        {

            //N�mero 40 -> En romano: XL
            var romano = RomanoGenerator();
            var test = romano.GetRomano(40);
            Assert.AreEqual("XL", test);
        }

        [Test]
        public void RomanoGeneratorPrueba13()
        {

            //N�mero 50 -> En romano: L
            var romano = RomanoGenerator();
            var test = romano.GetRomano(50);
            Assert.AreEqual("L", test);
        }

        [Test]
        public void RomanoGeneratorPrueba14()
        {

            //N�mero 26 -> En romano: XXVI
            var romano = RomanoGenerator();
            var test = romano.GetRomano(26);
            Assert.AreEqual("XXVI", test);
        }

        [Test]
        public void RomanoGeneratorPrueba15()
        {

            //N�mero 27 -> En romano: XXVII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(27);
            Assert.AreEqual("XXVII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba16()
        {

            //N�mero 100 -> En romano: C
            var romano = RomanoGenerator();
            var test = romano.GetRomano(100);
            Assert.AreEqual("c", test);
        }

        [Test]
        public void RomanoGeneratorPrueba17()
        {

            //N�mero 101 -> En romano: CI
            var romano = RomanoGenerator();
            var test = romano.GetRomano(101);
            Assert.AreEqual("CI", test);
        }

        [Test]
        public void RomanoGeneratorPrueba18()
        {

            //N�mero 102 -> En romano: CII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(102);
            Assert.AreEqual("CII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba19()
        {

            //N�mero 103 -> En romano: CIII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(103);
            Assert.AreEqual("CIII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba20()
        {

            //N�mero 104 -> En romano: CIV
            var romano = RomanoGenerator();
            var test = romano.GetRomano(104);
            Assert.AreEqual("CIV", test);
        }

        [Test]
        public void RomanoGeneratorPrueba21()
        {

            //N�mero 105 -> En romano: CV
            var romano = RomanoGenerator();
            var test = romano.GetRomano(105);
            Assert.AreEqual("CV", test);
        }

        [Test]
        public void RomanoGeneratorPrueba22()
        {

            //N�mero 106 -> En romano: CVI
            var romano = RomanoGenerator();
            var test = romano.GetRomano(106);
            Assert.AreEqual("CVI", test);
        }

        [Test]
        public void RomanoGeneratorPrueba23()
        {

            //N�mero 107 -> En romano: CVII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(107);
            Assert.AreEqual("CVII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba24()
        {

            //N�mero 108 -> En romano: CVIII
            var romano = RomanoGenerator();
            var test = romano.GetRomano(108);
            Assert.AreEqual("CVIII", test);
        }

        [Test]
        public void RomanoGeneratorPrueba25()
        {

            //N�mero 110 -> En romano: CX
            var romano = RomanoGenerator();
            var test = romano.GetRomano(110);
            Assert.AreEqual("CX", test);
        }
    }
}