class Musica:
  def __init__(self, t,a, al):
    self.__titulo = t #privatizado
    self.artista = a
    self.album = al #self e tipo this no c# so que no python é obrigatorio
  def __str__(self):
    return f"{self.titulo} - {self.artista} - {self.album}"

m1 = Musica("Easy", "Ivete", "Ao Vivo")
print(m1)