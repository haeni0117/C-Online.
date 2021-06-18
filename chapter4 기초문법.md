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
