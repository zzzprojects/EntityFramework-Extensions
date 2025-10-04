namespace EFCore.Benchmarks
{
    public static class BenchmarkHelper
    {
        public const string ZzzString = "zzzzzzzzzzzzz";

        public static List<TestEntity> GenerateTestEntities(int count)
        {
            var list = new List<TestEntity>();

            for (int i = 0; i < count; i++)
            {
                list.Add(new TestEntity() { 
                    Col1 = i, 
                    Col2 = i, 
                    Col3 = i, 
                    Col4 = i, 
                    Col5 = i, 
                    Col6 = ZzzString + i,
                    Col7 = ZzzString + i,
                    Col8 = ZzzString + i,
                    Col9 = ZzzString + i,
                    Col10 = ZzzString + i,
                });
            }

            return list;
        }

        public static List<TestEntity> GenerateTestEntitiesWithGraph(int count, int includeGraphChildCount)
        {
            var list = new List<TestEntity>();

            for (int i = 0; i < count; i++)
            {
                var entity = new TestEntity()
                {
                    Col1 = i,
                    Col2 = i,
                    Col3 = i,
                    Col4 = i,
                    Col5 = i,
                    Col6 = ZzzString + i,
                    Col7 = ZzzString + i,
                    Col8 = ZzzString + i,
                    Col9 = ZzzString + i,
                    Col10 = ZzzString + i,
                    ChildEntities = new List<TestChildEntity>()
                };

                for (int j = 0; j < includeGraphChildCount; j++)
                {
                    entity.ChildEntities.Add(new TestChildEntity()
                    {
                        Col1 = i,
                        Col2 = i,
                        Col3 = i,
                        Col4 = i,
                        Col5 = i,
                        Col6 = ZzzString + i,
                        Col7 = ZzzString + i,
                        Col8 = ZzzString + i,
                        Col9 = ZzzString + i,
                        Col10 = ZzzString + i,
                    });
                }

                list.Add(entity);
            }

            return list;
        }

        public static List<TestCompositeKeyEntity> GenerateTestCompositeKeyEntities(int count)
        {
            var list = new List<TestCompositeKeyEntity>();

            for (int i = 0; i < count; i++)
            {
                list.Add(new TestCompositeKeyEntity()
                {
                    ID1 = i,
                    ID2 = i,
                    Col1 = i,
                    Col2 = i,
                    Col3 = i,
                    Col4 = i,
                    Col5 = i,
                    Col6 = ZzzString + i,
                    Col7 = ZzzString + i,
                    Col8 = ZzzString + i,
                    Col9 = ZzzString + i,
                    Col10 = ZzzString + i,
                });
            }

            return list;
        }
    }
}
