# Nullable (Null 허용 값 형식)
- 참고 링크 : <https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/nullable-value-types>
***
- Null 허용 값 형식 <T>?는 기본 값 형식 <T>의 모든 값과 추가 null값을 나타낸다.
  - ex) bool? 변수는 true, false, null 을 할당할 수 있다.
- Null 허용 값 형식은 제네릭 System.Nullable<T> 구조체의 인스턴스이다.
- 기본 값 형식의 정의되지 않은 값을 표시해야 하는 경우 일반적으로 null 허용 값 형식을 사용합니다.
  - 예를들어 부울(bool) 변수는 true 와 false만 가능하다.
  - 그러나 일부 어플리케이션에서는 변수 값이 정의되지 않았거나 누락될 수 있다.
    - ex) 데이터베이스 필드는 true, false 를 포함하거나 아무값도 없을 수 있다.(즉 NULL)
    - 이럴때 bool? 형식을 사용할 수 있다.
    
***
