## MSSQL 정리
---
#### C# 데이터베이스 연결하기
SELECT 쿼리문 작성 -> ReadQuery ->
- foreach문 DataRow값 추출
- AsEnumerable().Select 으로 필드 추출 
-- ex) var division = resultDt.AsEnumerable().Select(data => data.Field<string>("DIVISION")).Distinct();
- row [][]의 형태로 불러올수 있음
-- row[컬럼][n번째]
---
#### 날짜/시간 변환
참고 링크 : [날짜/시간 변환 정리](https://chachahoya.tistory.com/74)
- 2020-01-01 13:00:00 형태
--  CONVERT(CHAR(23), DATETIME, 21)

- 2000-01-01 형태
--  CONVERT(CHAR(10), DATETIME, 23)

- 13:00:00 형태
--  CONVERT(CHAR(8), DATETIME, 24)
---
#### Numeric
- 고정 소수점값 사용법 => Numeric(p, [s])
- p는 소수점 이하자리를 포함한 총 자릿수, s는 소수점 이하 자릿수를 의미
- []는 생략가능
-- s를 생략하면 기본값으로 0이된다.
- ex) Numeric(4,2) 이렇게 정의하면 총 4자리이고, 소수점이하 2자리의 형식을 가진 숫자를 의미힌다. ex)24.25
---
#### PIVOT
- 행렬변환
- 사용법)

```
 SELECT 컬럼명
 FORM 테이블명
 PIVOT(집계함수(집계컬럼명)FOR 대상컬럼명 IN (컬럼이될 값)) AS 피벗테이블명

//집계함수 : SUM(합계), AVG(평균), COUNT(개수), MAX/MIN(최대/최소)
 ```