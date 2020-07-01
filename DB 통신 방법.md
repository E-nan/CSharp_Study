## C# DB 통신

1. ADO.Net
- db커넥션 열고 쿼리문 작성 ->  결과값을 받아서 처리
- Winform, Classic ASP

2. Enterprise Library 5
- ADO.NET과 동일하게 쿼리문을 직접작성 -> 결과값을 받아서 처리
- ADO.NET보다 Core 기능이 향상됨 (ex. Logging: 로그 처리 기능)

위 두가지의 문제점 => 쿼리문을 직접 작성 (JAVA의 JDBC처럼) => 오류의 발생소지가 높아짐
(오류가 발생하면 쿼리확인 및 코드확인 => 쿼리의 이해도 필요 (쿼리가 DB 통신의 중심이였다.))

ORM => Object Relation Mapping (객체 관계 매핑)
쿼리와 코드를 상호연동시켜서 (매핑시켜서) 직접 쿼리를 작성하지 않고도 DB 통신을 할 수 있게 해준다.
대표적인 예) Entity Framework, Mapper, Dapper

3. Entity Framwork
- Entity Framwork 1.0 ~ 6.0 => .Net Framwork
- ASP.NET Core => 7.0 => EntityFramework Core
- EF에서 CRUD를 하기 위해 LINQ를 이용하는데 이를 Linq to Entity 라고 하며, 직접 쿼리 또한 사용이 가능하다.

- 개발방식
  - 1) Database First 방식
  - Database DBA(데이터베이스 관리자)가 이미 설계 해놓은 상태
  - 물리적 데이터베이스도 완성된 상태
  - 즉 Database 기준으로 Application을 개발
  - => 대기업 및 체계가 갖춰져 있는 곳에서 사용함 (퍼포먼스, 구성 문제)
  
  -2) Code First 방식
  - Code 에서 Database를 생성해 Application을 개발
  - => 개발자가 Database를 설계 및 구성하고, 퍼포먼스는 예외에 두고 사용한다.(추후 프로파일링, 툴 등을 사용해 퍼포먼스 향상)
  
  
4. Dapper
- (EF와 비교했을때)모델링은 XML ORM, 역할은 Dapper가 한다.
  
  
  
  
- 커넥션 스트링(Conection String)
  - https://www.connectionstrings.com/ <== DB에 따른 커넥션 스트링을 볼 수 있다.
