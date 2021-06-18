# chapter 04 기초문법 제어하기
### 논리연산자
- 조건부 논리 : `&&` `||`
- 논리 부정 연산자 : `!`
  - 게임에서의 toggle
  - ex) 불 on/off : 불 껐다 켜기
    - light on  + toggle = light off
    - light off + toggle = light off

|A|B|&#38;&#38;|&#124;&#124;|
|------|---|---|-----|
|`true` | `true` | `true`|`true`|
|`true` | `false` | `false`|`true`|
|`false` | `true` | `false`|`true`|
|`false` | `false` | `false`|`false`|
### 조건연산자
- 삼항연산자 : 피연산자가 3개
- 형식 : `조건식` ? `처리1` : `처리2` 
- 조건식이 true이면 `처리1`, false면 `처리2`를 해라
### 비트연산자
- 비트 단위로 데이터를 처리
- `<<`,`>>`
### 비트논리연산자
- `^`,`&`,`|`,`~`
### null 병합연산자
- null값을 체크하는 연산자
- source code #41
```namespace _041_Operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b;
            Console.WriteLine("result: " + result);

            result = a ?? c ?? d;
            Console.WriteLine("result: " + result);
        }
    }
}
```
`int?` 는 int형과 null 모두 저장할 수 있지만, `int`는 오직 int형만 가능하다. 따라서 int형인 b라는 변수에 null값은 저장할 수 없다. 
```
int b = null (x)
int? a = null (o)
```
