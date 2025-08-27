module.exports = {
  purge: [],
  darkMode: 'media', // or 'media' or 'class'
  theme: {
    fontFamily: {
      sans: ['Inter', 'Arial', 'sans-serif'],
      serif: ['Recoleta', 'serif']
    },
    fontSize: {
      'xs': '.75rem',
      'sm': '.875rem',
      'tiny': '.875rem',
      'base': '1rem',
      'h3d': '1.375rem',
      'xl': '1.25rem',
      '2xl': '1.5rem',
      '2.5xl': '1.75rem',
      '3xl': '1.875rem',
      '4xl': '2.25rem',
      '4xlp': '2.5rem',
      '5xl': '3rem',
      'tsl': '3.75rem',
      '6xl': '4rem',
      '7xl': '5rem',
      '8xl': '6.25rem',
      '9xl': '7rem',
     },
    extend: {
     transitionProperty: {
       'max-height': 'max-height',
       'margin': 'margin'
     },
     padding: {
      '4+': '1.125rem'
     },
      gridTemplateColumns: {
        // Simple 12 column grid
       '12': 'repeat(12, minmax(0, 1fr))',
        // Complex site-specific column configuration
       'complex': '200px minmax(900px, 1fr) 100px',
      },
      colors: {
        morado: {
          100: '#E4DAFF',
          200: '#B8A6E9',
          300: '#987DE0',
          400: '#613DBC',
          500: '#4A25AA',
          600: '#2D098C'        
        },
        rosa: {
          100: '#FFDBF3',
          200: '#FBA6DF',
          300: '#F772CB',
          400: '#F23DB7',
          500: '#FE3799',
          600: '#E10098',
          700: '#9A0068'
        },
        gris: {
          50: '#F4F5F7',
          100: '#CED4DA',
          200: '#AAB1B8',
          300: '#868E96',
          400: '#727980',
          500: '#43494F',
          600: '#373E44',
          700: '#2E353B',
          800: '#252C33',
          900: '#191F28',
          950: '#10151D'
        },
        categoria: {
          'fuerza': '#A01727',
          'funcional': '#1F60F6',
          'yoga': '#94D82D',
          'pilates': '#51CF66',
          'barre': '#20C997',
          'box': '#F42929',
          'indoor': '#03A9F4',
          'running': '#FDDB2C',
          'remo': '#BE4BDB'

        }
      },
    },
  },
  variants: {
    extend: {
      grayscale: ['hover'], 
    },
  },
  plugins: [],
}


