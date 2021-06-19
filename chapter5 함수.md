### 메소드(함수)
- 특정 코드를 모아둔 코드 블록({ ~ })
- 특정 기능을 분리해서 처리
- `접근 지정자` `반환 데이터형식` 메소드명(`매개변수`, ...)
- 함수의 형태

|  |리턴형|파라미터|
|---|---|------|
|type1|x|x|
|type2|o|x|
|type3|o|o|
|type4|x|o|
* return이 나오면 멈추고 더이상 아래의 코드를 실행하지 않음

### Call by Value
- 값에 의한 호출
- 함수에서 값에 영향을 주지 않는다
- 일반 함수
- void swap(int a, int b)
### Call by Reference
- 주소에 의한 호출
- 함수에서 값에 영향을 준다
- <span style="color:red">ref</span> 키워드를 가지는 함수
- void <span style="color:red">swap</span> (ref int a, ref int b) -> *대부분의 예제에서 swap함수를 사용한다.*
- <span style="color:yellow">레퍼런스를 사용해야 퍼포먼스가 좋아진다.</span>
-> 주소만 알려주면 메모리가 주소값에 가서 처리가능 : 적은 데이터로 큰 데이터 처리 가능해지기 때문
```
namespace _062_FuncSwap
{
    class Program
    {
        static public void ValueSwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("num1: {0}    num2: {1}", a, b);
        }

        static public void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("RefSwap");
            Console.WriteLine("num1: {0}    num2: {1}", a, b);
        }
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = -100;

            ValueSwap(num1, num2);
            Console.WriteLine("num1: {0}   num2: {1}", num1, num2);

            RefSwap(ref num1, ref num2);
            Console.WriteLine("num1: {0}   num2: {1}", num1, num2);
        }
    }
}
```
### 메소드 오버로딩
- 메소드 이름이 중복
- 파라미터의 형식 다르게
- 파라미터의 수 다르게
- ex
    - static int Add(int a, int b)
    - static int Add(int a, int b, int c)
    - static int Add(float a, float b)
    - 위의 세 함수는 파라미터가 모두 다르기 때문에 함수명은 같지만 <span style="color:yellow">모두 다른 함수이다</span>.
    - 모호성으로 내가 call하기를 원하지 않는 함수가 호출될 수 있다.
### params
- 파라미터 제한 없이 처리
- int Total(params int[] values)
- 매개변수를 어떻게 관리하냐에 따라서 함수의 속성이 달라진다.
```
namespace _066_Func_params
{
    class Program
    {
        static int Total(params int[] values)
        {
            int total = 0;

            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        static void CheckValues(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Value: {0}   {1}", values[i], values[i].GetType() );
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Total: " + Total(200, 5, 3, 1, 100));
            Console.WriteLine("Total: " + Total(1, 2, 3, 4, 5));
            Console.WriteLine("Total: " + Total(10, 1000));

            CheckValues(0, 10.2f, 10.4, 10434839840d, "Hello World!");
        }
    }
}
```
- `object` : 모든 데이터형 사용 가능하다(상위클래스)
- 파라미터 타입이 다양하지만 내부코드가 같을 때 -> 굳이 오버로딩하지 말고, params를 사용한다.
- params를 남용하면 boxing과 unboxing이 너무 많이 사용되기 때문에 지나친 사용은 지양해야한다.