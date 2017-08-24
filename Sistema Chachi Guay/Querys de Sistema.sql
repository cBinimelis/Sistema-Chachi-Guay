create view vManga as
select m.id_Manga, m.Nombre, m.Sinopsis, m.Lanzamiento, m.Tomos, m.Imagen, m.id_GeneroManga, m.Otros_Generos, m.id_estado, u.id_Usuario, u.Nick
from Manga m 
inner join Usuario u on u.id_Usuario = m.id_Usuario;


create view vAnime as
select a.id_Anime, a.Nombre, a.Sinopsis, a.Lanzamiento, a.Temporadas, a.CapitulosTotales, a.Imagen, a.id_GeneroManga, a.Otros_Generos, a.id_estado, u.id_Usuario, u.Nick
from Anime a
inner join Usuario u on u.id_Usuario = a.id_Usuario