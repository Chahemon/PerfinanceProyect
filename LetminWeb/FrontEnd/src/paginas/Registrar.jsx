import { useState } from 'react'
import { Link } from 'react-router-dom'

const Registrar = () => {

  const [ nombre, setNombre ] = useState('')
  const [ email, setEmail ] = useState('')
  const [ password, setPassword ] = useState('')
  const [ repetirPassword, setRepetirPassword ] = useState('')

  return (
    <>
      <h1 className="text-sky-600 font-black text-6xl">Crea tu Cuenta y 
      Administra tus<span className="text-orange-600" > Finanzas</span>
      </h1>

      <form className="my-10 bg-white shadow rounded-lg p-10">
        <div className="my-5">
          <label 
              className="uppercase text-gray-600 block text-xl font-bold"
              htmlFor="nombre"
          >Nombre</label>
          <input
              id="nombre"
              type="text"
              placeholder="Tu Nombre"
              className="w-full mt-3 p-3 border rounded-xl bg-gray-50"
              value={nombre}
              onChange={ e => setNombre( e.target.value ) }
          />
        </div>
        <div className="my-5">
          <label 
              className="uppercase text-gray-600 block text-xl font-bold"
              htmlFor="email"
          >Email</label>
          <input
              id="email"
              type="email"
              placeholder="Email de Registro"
              className="w-full mt-3 p-3 border rounded-xl bg-gray-50"
              value={email}
              onChange={ e => setEmail( e.target.value ) }
          />
        </div>
        <div className="my-5">
          <label 
              className="uppercase text-gray-600 block text-xl font-bold"
              htmlFor="password"
          >Password</label>
          <input
              id="password"
              type="password"
              placeholder="Password de Registro"
              className="w-full mt-3 p-3 border rounded-xl bg-gray-50"
              value={password}
              onChange={ e => setPassword( e.target.value ) }
          />
        </div>
        <div className="my-5">
          <label 
              className="uppercase text-gray-600 block text-xl font-bold"
              htmlFor="password2"
          >Repetir Password</label>
          <input
              id="password2"
              type="password"
              placeholder="Repetir tu Password"
              className="w-full mt-3 p-3 border rounded-xl bg-gray-50"
              value={repetirPassword}
              onChange={ e => setRepetirPassword( e.target.value ) }
          />
        </div>

        <input 
            type="submit"
            value="Crear Cuenta"
            className="bg-sky-700 mb-5 w-full py-3 text-white uppercase font-bold rounded
            hover:cursor-pointer hover:bg-sky-800 transition-colors"
        />

      </form>

      <nav className="lg:flex lg:justify-between">
          <Link
              className="block text-center my-5 text-slate-500 uppercase text-sm"
              to="/"
          >¿Ya tienes una cuenta? Inicia Sesión</Link>

          <Link
              className="block text-center my-5 text-slate-500 uppercase text-sm"
              to="/olvide-password"
          >Olvide Mi Password</Link>
      </nav>

    </>
  )
}

export default Registrar
