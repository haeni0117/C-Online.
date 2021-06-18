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
### 지역변수
- {} 코드 블록 내부에 선언
- 코드 블록 외부에서는 사용 불가
### 분기문(branch) - if
- 특정 조건을 이용하여 코드를 다른 섹션으로 분기
- `if`, `if ~ else`, `if ~ else if ~ else`
- 중첩으로 사용가능
```
static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            string strNum = Console.ReadLine();
            int a = int.Parse(strNum);

            if(a > 0)
            {
                Console.WriteLine("입력한 수는 양수!!");
            } 
            else if(a < 0)
            {
                Console.WriteLine("입력한 수 음수!!");
            }
            else
            {
                Console.WriteLine("입력한 수 0이다");
            }
        }
```


### 분기문(branch) - switch
- switch : if문과 다르게 여러 개의 조건식이 있을 경우
### 반복문 - for, while, do ~ while
```
while(조건식){
  `반복되는 코드`
}

do{
  반복되는 코드
}while(조건식);

for(초기식,조건식,증감식){
  반복되는 코드
}
```
### 반복문 - 중첩 for, foreach
- 중첩 for -> 여러 번 중첩가능
- for each
  - for문과 동일하게 작동
  - 차후에 배열, collection에서 사용 
### 무한반복 - while, for
``` 
while(true){
  무한반복코드
}
```
```
for(초기식 ; 조건식 ; 증감식 ){
  무한반복코드
}
```
### 점프문(break, continue, goto)
- 무한루프 제어
  - break
  - continue
  - goto 
    - 코드의 흐름이 깨지고, 어디로 이동하는지 찾기 어렵기 떄문에 비추 + 가독성 떨어짐
```
static void Main(string[] args)
        {
            int inputNum = 0;

            while(true) //for(;;)
            {
                Console.Write("(1)구구단 중 몇단?  (2)나가기(0번 입력)");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum == 0)
                {
                    Console.WriteLine("종료 합니다.");
                    break;
                }

                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", inputNum, i, (inputNum * i));
                }
            }
        }
```