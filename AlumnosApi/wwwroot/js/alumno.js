
const url = '/api/alumnos';
const urlCursos = '/api/cursos';

const obtenerCursos = async () => {

  console.log("cargando cursos...");

  let cursos = [];

  cursos = await fetchGET(urlCursos);

  console.log("cursos", cursos)

  let selectCursos = document.getElementById("selectCurso");

  cursos.forEach(curso => {

    let option = document.createElement("option");

    option.text = curso.nombre;
    option.value = curso.id;

    selectCursos.add(option);


  })

}

obtenerCursos();

const obtenerAlumnos = async () => {

  console.log("cargando alumnos...");

  let alumnos = [];

  alumnos = await fetchGET(url)

  document.getElementById("dvAlumnos").appendChild(toTable(alumnos))

  console.log("alumnos", alumnos)

  let selectAlumnos = document.getElementById("selectAlumno");

  selectAlumnos.innerHTML = '';

  alumnos.forEach(alumno => {

    let option = document.createElement("option");

    option.text = alumno.nombre + " " + alumno.apellido;
    option.value = alumno.id;

    selectAlumnos.add(option);

  })

}

obtenerAlumnos();

const crear = async () => {

  let data = {};

  data.nombre = document.getElementById("txtNombre").value;
  data.cursoid = parseInt(document.getElementById("selectCurso").value);

  console.log(data)

  fetchPOST(url, data)

};

const eliminar = async () => {

  let id = parseInt(document.getElementById("selectAlumno").value)

  fetchDELETE(url + "/" + id);

  obtenerAlumnos();

}