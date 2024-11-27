using Microsoft.AspNetCore.Components;

namespace BlazorTuSo0.Components.Pages;

    public class ComputeBase : ComponentBase{
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num { get; set; }

        // Phương thức tính toán
        public void Calculate()
        {
            Num = Num1 + Num2;
        }

        // Phương thức xóa dữ liệu
        public void Clear()
        {
            Num1 = 0;
            Num2 = 0;
            Num = 0;
        }
    }

