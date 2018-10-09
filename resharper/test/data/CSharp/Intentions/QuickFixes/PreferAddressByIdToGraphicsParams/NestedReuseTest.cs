using UnityEngine;

namespace DefaultNamespace
{
    public class NestedReuseTest
    {
        public class Nested
        {
            private static int Property { get; } = Shader.PropertyToID("test")
            
            public void Method(Material material)
            {
                material.SetFloat("te{caret}st", 10.0f);
            }
        }
    }
}