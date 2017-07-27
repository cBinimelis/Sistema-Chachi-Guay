create view vManga as
select m.id_Manga, m.Nombre, m.Sinopsis, m.Lanzamiento, m.Tomos, m.Imagen, m.id_GeneroManga, m.Otros_Generos, m.id_estado, u.id_Usuario, u.Nick
from Manga m 
inner join Usuario u on u.id_Usuario = m.id_Usuario