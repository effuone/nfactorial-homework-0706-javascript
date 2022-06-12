const meow = require('meow');
const meowHelp = require('cli-meow-help');

const flags = {
	clear: {
		type: `boolean`,
		default: false,
		alias: `c`,
		desc: `Clear the console`
	},
	noClear: {
		type: `boolean`,
		default: true,
		desc: `Don't clear the console`
	},
	debug: {
		type: `boolean`,
		default: false,
		alias: `d`,
		desc: `Print debug info`
	},
	version: {
		type: `boolean`,
		alias: `v`,
		desc: `Print CLI version`
	},
	limit: {
		type: `number`,
		alias: `lim`,
		default: 1,
		desc: `How many interesting facts do you want to know?`
	},
	api: {
		type: `string`,
		alias: `key`,
		default: `EZiEk20mKWRx6ho0oQfrhQ==i86ezA66E3Lrttzt`,
		desc: `Enter your API Key to get information. If you dont have one, please get it from https://api-ninjas.com/`
	}
};

const commands = {
	help: { desc: `Print help info` }
};

const helpText = meowHelp({
	name: `fact`,
	flags,
	commands
});

const options = {
	inferType: true,
	description: false,
	hardRejection: false,
	flags
};



module.exports = meow(helpText, options);
