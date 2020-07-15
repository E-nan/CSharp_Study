MS SQL
기본포트 : 1433
SQL Server
1) SQL 엔진
2) Management Studio

모두 설치 필요

### MSSQL SA계정 비밀번호 설정
- 보안 => 로그인 => sa (super admin)
- 프로젝트를 만들게 되면 배포할때 sa계정을 이용하면 안된다. 
- sa 우클릭 => 속성

변경 이유?
- Web Server와 SQL Server가 다른 컴퓨터일 경우 (SQL Server에 접근가능한 계정이 필요)
