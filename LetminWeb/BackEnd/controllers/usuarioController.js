import Usuario from "../models/Usuario.js"
import generarId from "../helpers/generarld.js"
import generarJWT from "../helpers/generarJWT.js"

const registrar = async ( req, res ) => {
    // Evitar registros duplicados
    const { email } = req.body
    const existeUsuario = await Usuario.findOne({ email })

    if ( existeUsuario ) {
        const error = new Error( 'Usuario ya registrado' )
        return res.status( 400 ).json({ msg: error.message })
    }

    try {
        const usuario = new Usuario(req.body)
        usuario.token = generarId()
        const usuarioAlmacenado = await usuario.save()
        res.json( usuarioAlmacenado )
        
    } catch ( error ) {
        console.log( error )
    }
}

const autenticar = async (req, res) => {
    const { email, password } = req.body

    // Comprobar si el usuario existe
    const usuario = await Usuario.findOne({email})
    if ( !usuario ) {
        const error = new Error("El usuario no existe")
        return res.status(404).json({ msg: error.message })
    }

    // Comprobar si el usuario esta confirmado
    if ( !usuario.confirmado ) {
        const error = new Error("Tu Cuenta no ha sido confirmada")
        return res.status(403).json({ msg: error.message })
    }

    // Comprobar el password
    if ( await usuario.comprobarPassword(password) ) {
        res.json({
            _id: usuario._id,
            nombre: usuario.nombre,
            email: usuario.email,
            token: generarJWT( usuario._i ),
        })
    } else {
        const error = new Error("El Password es Incorrecto")
        return res.status(403).json({ msg: error.message })
    }
}

const confirmar = async (req, res) => {
    
    const { token } = req.params
    const usuarioConfirmar = await Usuario.findOne({ token })
    if ( !usuarioConfirmar ) {
        // Si no se encuentra un usuario con el token, no sera valido
        const error = new Error("Token no valido")
        return res.status(403).json({ msg: error.message })
    }

    try {
        //Si encontramos el usuario con ese token, lo confirmamos y eliminamos el token
        usuarioConfirmar.confirmado = true
        usuarioConfirmar.token = ""

        // Guardamos los cambios en el usuario
        await usuarioConfirmar.save()
        res.json({msg: 'Usuario Confirmado Correctamente'})

    } catch ( error ) {
        console.log( error )
    }
}

const olvidePassword = async (req, res) => {
    const { email } = req.body
    const usuario = await Usuario.findOne({email})
    if ( !usuario ) {
        const error = new Error("El usuario no existe")
        return res.status(404).json({ msg: error.message })
    }

    try {
        usuario.token = generarId()
        await usuario.save()
        res.json({ msg: "Hemos enviado un email con las instrucciones" })
    } catch ( error ) {
        console.log( error )
    }
}

const comprobarToken = async (req, res) => {
    const { token } = req.params

    const tokenValido = await Usuario.findOne({ token })

    if ( tokenValido ) {
        res.json({ msg: "Token válido y el Usuario existe" })
    } else {
        const error = new Error("Token no válido")
        return res.status(404).json({ msg: error.message })
    }
}

const nuevoPassword = async (req, res) => {
    const { token } = req.params
    const { password } = req.body

    const usuario = await Usuario.findOne({ token })

    if ( usuario ) {
        usuario.password = password
        usuario.token = ""
        try {
            await usuario.save()
            res.json({ msg: "Password Modificado Correctamente" })
        } catch ( error ) {
            console.log( error )
        }
    } else {
        const error = new Error("Token no válido")
        return res.status(404).json({ msg: error.message })
    }
}

const perfil = async (req, res) => {
    const { usuario } = req
    res.json( usuario )
}

export { 
    registrar, 
    autenticar, 
    confirmar, 
    olvidePassword, 
    comprobarToken, 
    nuevoPassword,
    perfil,
}