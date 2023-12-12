# Nama dan NIM
| Nama       | NIM |
|--------------|------:|
| Moh Rizky Arif |  21/478613/TK/52741 |

# Setting Up the Database
```sql
create database responsi2;
```
```sql
\c responsi2
```
```sql
create table departemen(id_dep int primary key, nama_dep varchar);
create sequence karyawan_seq start 1;
create table karyawan(id_karyawan varchar(6) default 'K' || nextval('karyawan_seq') primary key, nama varchar(30), id_dep int, 
	constrain fk_dep foreign key(id_dep) 
	references departemen(id_dep));
```

```sql
create or replace function k_insert(_nama varchar, _id_dep int)
returns int as
'
begin
	insert into public.karyawan(nama, id_dep)
		values (_nama, _id_dep);
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;
```

```sql
create or replace function k_update(_id_karyawan varchar, _nama varchar, _id_dep int)
returns int as
'
begin
	update public.karyawan SET nama = _nama, id_dep = _id_dep where id_karyawan = _id_karyawan;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;
```

```sql
create or replace function k_delete(_id_karyawan varchar)
returns int as
'
begin
	delete from public.karyawan where id_karyawan = _id_karyawan;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'
language plpgsql;
```

```sql
create function k_select()
returns table
(_id_karyawan varchar, _nama varchar, _id_dep int)
language plpgsql as
'
begin
	return query select id_karyawan, nama, id_dep from public.karyawan;
end
'
```